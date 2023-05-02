namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text Default.
/// </summary>
public class TextDefault: ModelElement
{
  public ShapeProperties? ShapeProperties { get; set; }

  public BodyProperties? BodyProperties { get; set; }

  public ListStyle? ListStyle { get; set; }

  public ShapeStyle? ShapeStyle { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}