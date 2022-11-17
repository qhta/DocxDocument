namespace DocumentModel.Drawing.Charts;

public interface IScaling // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ILogBase? LogBase { get ; set; }

  public IOrientation? Orientation { get ; set; }

  public IMaxAxisValue? MaxAxisValue { get ; set; }

  public IMinAxisValue? MinAxisValue { get ; set; }

  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }

}
