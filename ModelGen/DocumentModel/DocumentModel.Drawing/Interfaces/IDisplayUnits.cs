namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
public interface IDisplayUnits // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Double? CustomDisplayUnit { get ; set; }
  
  public BuiltInUnitKind? BuiltInUnit { get ; set; }
  
  public IDisplayUnitsLabel? DisplayUnitsLabel { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
