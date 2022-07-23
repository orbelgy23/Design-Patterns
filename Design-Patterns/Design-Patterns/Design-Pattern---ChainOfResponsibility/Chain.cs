namespace Design_Pattern___ChainOfResponsibility
{

    public class Chain
    {

        #region // PROPERTIES //


        private Node Head { get; set; } = null;
        private Node Last { get; set; } = null;


        #endregion


        #region // METHODS //


        public void Add(Action<DataContainer> newAction)
        {
            if (Last == null)
            {
                var firstChain = new Node(newAction);
                Head = firstChain;
                Last = firstChain;
            }
            else
            {
                Last.NextNode = new Node(newAction);
                Last = Last.NextNode;
            }
        }

        public void Calculate(DataContainer obj)
        {
            Node RealHead = Head;
            while (Head != null)
            {
                Head.Operation(obj);
                Head = Head.NextNode;
            }
            Head = RealHead;
        }


        #endregion

    }
}
