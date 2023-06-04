using System.Runtime.CompilerServices;
using System.Threading;

using ModelGen;

namespace ModelGenApp;
public class Commander
{

  public Commander()
  {
    Start = new Start(this);
  }

  public Start Start { get; set;} 

  public bool IsRun => Creator?.IsRun == true;

  public BaseCreator? Creator { get; set; }
  public Task? Runner { get; set; }

  public CancellationToken StartGenerateModelTypes(Type rootType, MDS display = MDS.None, DisplayOptions? options = null)
  {
    var filePath = Assembly.GetExecutingAssembly().Location;
    var index = filePath.IndexOf(@"\bin");
    if (index > 0)
      filePath = filePath.Substring(0, index);
    filePath = Path.GetDirectoryName(filePath) ?? "";
    filePath = Path.GetDirectoryName(filePath) ?? "";
    filePath = Path.Combine(filePath, @"ModelGen\DocumentModel");
    Creator = new ModelCreator("DocumentModel", filePath);
    var cancellationToken = new CancellationToken();
    Runner = Task.Factory.StartNew(() =>
      { Creator.RunOn(rootType, display, options); }, cancellationToken);
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
