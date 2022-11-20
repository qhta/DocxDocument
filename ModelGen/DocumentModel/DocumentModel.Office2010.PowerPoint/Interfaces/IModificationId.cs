namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the ModificationId Class.
/// </summary>
public interface IModificationId // : DocumentFormat.OpenXml.Office2010.PowerPoint.RandomIdType
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Val { get ; set; }
  
}
