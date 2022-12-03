namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MultiLevelStringCache Class.
/// </summary>
public interface MultiLevelStringCache // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// PointCount.
  /// </summary>
  public UInt32? PointCount { get ; set; }
  
  public Collection<Level>? Levels { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
