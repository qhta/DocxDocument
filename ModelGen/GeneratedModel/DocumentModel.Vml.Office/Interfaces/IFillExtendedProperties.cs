namespace DocumentModel.Vml.Office;

public interface IFillExtendedProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public ExtensionHandlingBehavior? Extension { get ; set; }

  public Fill? Type { get ; set; }

}
