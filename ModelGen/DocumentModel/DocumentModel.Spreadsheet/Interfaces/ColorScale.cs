namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColorScale Class.
/// </summary>
public interface ColorScale // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<ConditionalFormattingValueObject>? ConditionalFormattingValueObjects { get ; set; }
  
  public Collection<ColorType>? Colors { get ; set; }
  
}
