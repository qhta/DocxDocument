namespace DocumentModel.Interop;

/// <summary>
/// Represents the linking characteristics for an OLE object or picture.
/// </summary>
public partial interface LinkFormat : InteropObject
{
  /// <summary>
  /// The auto update.
  /// </summary>
  public bool AutoUpdate { get; set; }

  /// <summary>
  /// The source name.
  /// </summary>
  public string SourceName { get; }

  /// <summary>
  /// The source path.
  /// </summary>
  public string SourcePath { get; }

  /// <summary>
  /// The locked.
  /// </summary>
  public bool Locked { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdLinkType Type { get; }

  /// <summary>
  /// The source full name.
  /// </summary>
  public string SourceFullName { get; set; }

  /// <summary>
  /// The save picture with document.
  /// </summary>
  public bool SavePictureWithDocument { get; set; }
}
