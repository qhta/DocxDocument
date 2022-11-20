namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Lock Class.
/// </summary>
public interface ILock // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Locking Type
  /// </summary>
  public LockingValues? Val { get ; set; }
  
}
