namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
public interface IDisplayUnits // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Double? CustomDisplayUnit { get ; set; }
  
  public DocumentModel.Drawing.BuiltInUnitKind? BuiltInUnit { get ; set; }
  
  public DocumentModel.Drawing.IDisplayUnitsLabel? DisplayUnitsLabel { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
