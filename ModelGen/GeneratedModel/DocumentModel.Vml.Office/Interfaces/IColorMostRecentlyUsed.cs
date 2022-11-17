namespace DocumentModel.Vml.Office;

public interface IColorMostRecentlyUsed // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public ExtensionHandlingBehavior? Extension { get ; set; }
  
  public string? Colors { get ; set; }
  
}
