namespace DocumentModel.Drawing;

public interface IPictureLocks // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? NoGrouping { get ; set; }

  public bool? NoSelection { get ; set; }

  public bool? NoRotation { get ; set; }

  public bool? NoChangeAspect { get ; set; }

  public bool? NoMove { get ; set; }

  public bool? NoResize { get ; set; }

  public bool? NoEditPoints { get ; set; }

  public bool? NoAdjustHandles { get ; set; }

  public bool? NoChangeArrowheads { get ; set; }

  public bool? NoChangeShapeType { get ; set; }

  public bool? NoCrop { get ; set; }

  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }

}
