namespace Design_Pattern___ChainOfResponsibility
{


    #region // ENUMS //


    public enum ChainType{
        FirstType = 0,
        SecondType = 1
    }


    #endregion


    public class ChainsOfResponsibility
    {

        #region // PROPERTIES //


        private Dictionary<ChainType, Chain> ChainsDictionary { get; set; }
            = new Dictionary<ChainType, Chain>();


        #endregion


        #region // METHODS //


        public void Add(ChainType type, Chain cor)
        {
            ChainsDictionary[type] = cor;
        }

        /// <summary>
        /// Given an Object and Request Type, Deliver the Object Between Nodes of a Specific Chain
        /// </summary>
        /// <param name="type">The Type of the Request</param>
        /// <param name="objectToDeliver">The Object to Deliver between Nodes of a Chain</param>
        public void Calculate(ChainType type, DataContainer objectToDeliver)
        {
            ChainsDictionary[type].Calculate(objectToDeliver);
        }


        #endregion

    }
}
