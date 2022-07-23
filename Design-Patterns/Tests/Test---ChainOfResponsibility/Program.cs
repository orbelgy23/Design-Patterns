using Design_Pattern___ChainOfResponsibility;


// Create some actions
Action<DataContainer> WriteToFileData1 = delegate (DataContainer obj)
{
    using (StreamWriter outputFile = new StreamWriter(obj.Path, true))
    {
        outputFile.WriteLine(obj.Data1);
    }
};

Action<DataContainer> WriteToFileData2 = delegate (DataContainer obj)
{
    using (StreamWriter outputFile = new StreamWriter(obj.Path, true))
    {
        outputFile.WriteLine(obj.Data2);
    }
};

Action<DataContainer> WriteToFileData3 = delegate (DataContainer obj)
{
    using (StreamWriter outputFile = new StreamWriter(obj.Path, true))
    {
        outputFile.WriteLine(obj.Data3);
    }
};

Action<DataContainer> WriteToFileData4 = delegate (DataContainer obj)
{
    using (StreamWriter outputFile = new StreamWriter(obj.Path, true))
    {
        outputFile.WriteLine(obj.Data4);
    }
};

Action<DataContainer> WriteToFileData5 = delegate (DataContainer obj)
{
    using (StreamWriter outputFile = new StreamWriter(obj.Path, true))
    {
        outputFile.WriteLine(obj.Data5);
    }
};



// Create The First and Second Chain Initialized with the Actions
Chain cor1 = new Chain();
Chain cor2 = new Chain();

cor1.Add(WriteToFileData1);
cor1.Add(WriteToFileData2);
cor1.Add(WriteToFileData3);

cor2.Add(WriteToFileData4);
cor2.Add(WriteToFileData5);


// Create The Chain Of Chains object
ChainsOfResponsibility chainsOfResponsibility = new ChainsOfResponsibility();

// Add the Chains to the Chain Of Chains
chainsOfResponsibility.Add(ChainType.FirstType, cor1);
chainsOfResponsibility.Add(ChainType.SecondType, cor2);


// Create the object that we are going to deliver to the chains
DataContainer objectToDeliver = new DataContainer();
objectToDeliver.Path = "./ChainOfResponsibilityLogFile.txt";
objectToDeliver.Data1 = "data1";
objectToDeliver.Data2 = "data2";
objectToDeliver.Data3 = "data3";
objectToDeliver.Data4 = "data4";
objectToDeliver.Data5 = "data5";


// Send to the ChainOfChains
chainsOfResponsibility.Calculate(ChainType.FirstType, objectToDeliver);
chainsOfResponsibility.Calculate(ChainType.SecondType, objectToDeliver);