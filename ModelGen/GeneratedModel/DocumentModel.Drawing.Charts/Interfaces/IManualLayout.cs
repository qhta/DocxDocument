namespace DocumentModel.Drawing.Charts;

public interface IManualLayout // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ILayoutTarget? LayoutTarget { get ; set; }

  public ILeftMode? LeftMode { get ; set; }

  public ITopMode? TopMode { get ; set; }

  public IWidthMode? WidthMode { get ; set; }

  public IHeightMode? HeightMode { get ; set; }

  public ILeft? Left { get ; set; }

  public ITop? Top { get ; set; }

  public DocumentModel.Drawing.Charts.IWidth? Width { get ; set; }

  public IHeight? Height { get ; set; }

  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }

}
