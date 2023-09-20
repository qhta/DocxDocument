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
