namespace DocumentModel.InOpenXml.Test;

public class BuiltInPropertiesDTO: DocumentModel.ModelElement
{
  private BuiltInProperties _builtInProperties = new BuiltInProperties();

  public CoreProperties CoreProperties => _builtInProperties.CoreProperties;

  public ContentProperties ContentProperties => _builtInProperties.ContentProperties;

  public StatisticProperties StatisticProperties => _builtInProperties.StatisticProperties;

}