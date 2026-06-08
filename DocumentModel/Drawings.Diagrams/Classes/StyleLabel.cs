namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   IStyle Label.
/// </summary>
public class StyleLabel: ModelElement
{
  /// <summary>
  ///   IStyle Name
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   3-D Scene.
  /// </summary>
  public Scene3D? Scene3D { get; set; }

  /// <summary>
  ///   3-D IShape Properties.
  /// </summary>
  public Shape3D? Shape3D { get; set; }

  /// <summary>
  ///   Text Properties.
  /// </summary>
  public TextProperties? TextProperties { get; set; }

  /// <summary>
  ///   IShape IStyle.
  /// </summary>
  public IStyle? IStyle { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
