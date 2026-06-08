namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Single Automatic Captioning Setting.
/// </summary>
public class IAutoCaption: ModelElement
{
  /// <summary>
  ///   Identifier of Object Ito be Automatically Captioned
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Caption Used for Automatic Captioning
  /// </summary>
  public string? Caption { get; set; }
}
