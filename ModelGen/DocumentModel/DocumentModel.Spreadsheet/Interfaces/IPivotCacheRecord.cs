namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache Record.
/// </summary>
public interface IPivotCacheRecord // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IMissingItem>? MissingItems { get ; set; }
  
  public Collection<INumberItem>? NumberItems { get ; set; }
  
  public Collection<IBooleanItem>? BooleanItems { get ; set; }
  
  public Collection<IErrorItem>? ErrorItems { get ; set; }
  
  public Collection<IStringItem>? StringItems { get ; set; }
  
  public Collection<IDateTimeItem>? DateTimeItems { get ; set; }
  
  public Collection<UInt32>? FieldItems { get ; set; }
  
}
