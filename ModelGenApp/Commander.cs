namespace ModelGenApp;
public class Commander
{

  public Commander()
  {
    Start = new Start(this);
  }

  public Start Start { get; set;} 

  public bool IsRun => creator?.IsRun == true;

  private BaseCreator? creator { get; set; }
  public Task? Runner { get; set; }

  public CancellationToken StartGenerateModelTypes(Type rootType, ProcessOptions options)
  {
    var filePath = Assembly.GetExecutingAssembly().Location;
    var index = filePath.IndexOf(@"\bin");
    if (index > 0)
      filePath = filePath.Substring(0, index);
    filePath = Path.GetDirectoryName(filePath) ?? "";
    filePath = Path.GetDirectoryName(filePath) ?? "";
    filePath = Path.Combine(filePath, @"ModelGen\DocumentModel");
    creator = new ModelCreator("DocumentModel", filePath);
    //creator.ModelMonitor=new ModelDisplay();
    var cancellationToken = new CancellationToken();
    Runner = Task.Factory.StartNew(() =>
      { creator.RunOn(rootType, options); }, cancellationToken);
    return cancellationToken;
  }

  public void GenerateTypeConverters(Type rootType)
  {
    var filePath = Assembly.GetExecutingAssembly().Location;
    var index = filePath.IndexOf(@"\bin");
    if (index > 0)
      filePath = filePath.Substring(0, index);
    filePath = Path.GetDirectoryName(filePath) ?? "";
    filePath = Path.GetDirectoryName(filePath) ?? "";
    filePath = Path.Combine(filePath, @"ModelGen\DocumentModel");
    var creator = new ConverterCreator("DocumentModel", filePath);
  }
}
