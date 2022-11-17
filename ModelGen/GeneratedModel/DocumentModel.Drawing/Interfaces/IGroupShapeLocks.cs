namespace DocumentModel.Drawing;

public interface IGroupShapeLocks // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? NoGrouping { get ; set; }
  
  public bool? NoUngrouping { get ; set; }
  
  public bool? NoSelection { get ; set; }
  
  public bool? NoRotation { get ; set; }
  
  public bool? NoChangeAspect { get ; set; }
  
  public bool? NoMove { get ; set; }
  
  public bool? NoResize { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
