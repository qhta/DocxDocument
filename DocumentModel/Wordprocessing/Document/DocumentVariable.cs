namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Single Document Variable.
/// </summary>
public class DocumentVariable: ModelElement
{
  /// <summary>
  ///   Document Variable Name
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   Document Variable Value
  /// </summary>
  public String? Val { get; set; }
}