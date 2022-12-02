namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColorScale Class.
/// </summary>
public interface IColorScale // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IConditionalFormattingValueObject>? ConditionalFormattingValueObjects { get ; set; }
  
  public Collection<IColorType>? Colors { get ; set; }
  
}
