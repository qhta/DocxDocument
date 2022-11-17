namespace DocumentModel.Drawing;

public interface IGraphicFrameLocks // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? NoGrouping { get ; set; }

  public bool? NoDrilldown { get ; set; }

  public bool? NoSelection { get ; set; }

  public bool? NoChangeAspect { get ; set; }

  public bool? NoMove { get ; set; }

  public bool? NoResize { get ; set; }

  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }

}
