namespace ChainOfResponsibilityPattern
{
    public abstract class Approve
    {
        protected Approve _successor;

        public void SetSuccessor(Approve approve)
        {
            _successor = approve;
        }

        public abstract void HandelRequest(Purchase purchase);
    }
}