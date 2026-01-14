namespace DocumentModel.Drawings;

/// <summary>
///   Represents locking options for a graphic frame, restricting user actions such as grouping, selection, movement, and resizing.
/// </summary>
public interface GraphicFrameLocks : IExtendableElement
{
  /// <summary>
  ///   Disallows grouping of the graphic frame.
  /// </summary>
  public bool? NoGrouping { get; set; }

  /// <summary>
  ///   Disallows selection of child shapes within the graphic frame.
  /// </summary>
  public bool? NoDrilldown { get; set; }

  /// <summary>
  ///   Disallows selection of the graphic frame.
  /// </summary>
  public bool? NoSelection { get; set; }

  /// <summary>
  ///   Disallows changing the aspect ratio of the graphic frame.
  /// </summary>
  public bool? NoChangeAspect { get; set; }

  /// <summary>
  ///   Disallows moving the graphic frame.
  /// </summary>
  public bool? NoMove { get; set; }

  /// <summary>
  ///   Disallows resizing the graphic frame.
  /// </summary>
  public bool? NoResize { get; set; }
}