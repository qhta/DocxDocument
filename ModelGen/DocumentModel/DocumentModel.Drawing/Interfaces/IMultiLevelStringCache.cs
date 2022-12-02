namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MultiLevelStringCache Class.
/// </summary>
public interface IMultiLevelStringCache // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// PointCount.
  /// </summary>
  public UInt32? PointCount { get ; set; }
  
  public Collection<ILevel>? Levels { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
