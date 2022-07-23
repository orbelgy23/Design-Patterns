namespace Design_Pattern___ChainOfResponsibility
{

    public class Node
    {

        #region // PROPERTIES //


        public Node NextNode { get; set; }

        public Action<DataContainer> Operation { get; set; }


        #endregion


        #region // METHODS //


        public Node(Action<DataContainer> newOperation)
        {
            NextNode = null;
            Operation = newOperation;
        }

        #endregion

    }
}