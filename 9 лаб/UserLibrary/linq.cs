using System;
using System.Collections.Generic;
using System.Linq;

public static class linq
{
    // Метод для выборки уникальных элементов из коллекции
    public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
    {
        var seen = new HashSet<TSource>();
        foreach (var item in source)
        {
            if (seen.Add(item))
            {
                yield return item;
            }
        }
    }

    // Метод для подсчета количества элементов в коллекции, удовлетворяющих заданному условию
    public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        int count = 0;
        foreach (var item in source)
        {
            if (predicate(item))
            {
                count++;
            }
        }
        return count;
    }

    // Метод для проверки, содержит ли коллекция хотя бы один элемент, удовлетворяющий заданному условию
    public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        foreach (var item in source)
        {
            if (predicate(item))
            {
                return true;
            }
        }
        return false;
    }

    // Метод для слияния двух коллекций по заданному условию
    public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(
        this IEnumerable<TOuter> outer,
        IEnumerable<TInner> inner,
        Func<TOuter, TKey> outerKeySelector,
        Func<TInner, TKey> innerKeySelector,
        Func<TOuter, TInner, TResult> resultSelector)
    {
        foreach (var outerItem in outer)
        {
            var outerKey = outerKeySelector(outerItem);
            foreach (var innerItem in inner)
            {
                var innerKey = innerKeySelector(innerItem);
                if (EqualityComparer<TKey>.Default.Equals(outerKey, innerKey))
                {
                    yield return resultSelector(outerItem, innerItem);
                }
            }
        }
    }

    // Метод для разделения коллекции на страницы с указанным размером страницы
    public static IEnumerable<IEnumerable<TSource>> Page<TSource>(
        this IEnumerable<TSource> source,
        int pageSize)
    {
        var currentPage = new List<TSource>();
        foreach (var item in source)
        {
            currentPage.Add(item);
            if (currentPage.Count == pageSize)
            {
                yield return currentPage;
                currentPage = new List<TSource>();
            }
        }
        if (currentPage.Any())
        {
            yield return currentPage;
        }
    }
}
