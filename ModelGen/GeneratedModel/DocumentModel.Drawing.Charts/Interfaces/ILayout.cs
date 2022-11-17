namespace DocumentModel.Drawing.Charts;

public interface ILayout // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IManualLayout? ManualLayout { get ; set; }

  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }

}
