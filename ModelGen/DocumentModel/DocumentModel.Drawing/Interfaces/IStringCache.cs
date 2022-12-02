namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StringCache Class.
/// </summary>
public interface IStringCache // : DocumentModel.Drawing.IStringDataType
{
  public UInt32? PointCount { get ; set; }
  
  public Collection<IStringPoint>? StringPoints { get ; set; }
  
  public IStrDataExtensionList? StrDataExtensionList { get ; set; }
  
}
