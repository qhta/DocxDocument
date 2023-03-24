namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ContourColor Class.
/// </summary>
public class ContourColor: ModelElement
{
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  public SchemeColor? SchemeColor { get; set; }
}