namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group Items.
/// </summary>
public interface IGroupItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Items Created Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IMissingItem>? MissingItems { get ; set; }
  
  public Collection<INumberItem>? NumberItems { get ; set; }
  
  public Collection<IBooleanItem>? BooleanItems { get ; set; }
  
  public Collection<IErrorItem>? ErrorItems { get ; set; }
  
  public Collection<IStringItem>? StringItems { get ; set; }
  
  public Collection<IDateTimeItem>? DateTimeItems { get ; set; }
  
}
