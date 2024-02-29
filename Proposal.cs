namespace VP_Pract1
{
    public class Proposal
    {
        public string Code;
        public string Title;
        public string Text;
        public string Date;
        public StatusPruposal status = StatusPruposal.Waiting;

        public void View() { }
        public void ViewStatus() { }
        public void Update() { }
        public void Delete() { }
        public void Archive() { }
        public void ViewApplicant() { }
    }
}