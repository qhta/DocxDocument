namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Single IDocument IVariable.
/// </summary>
public class DocumentVariable: ModelElement
{
  /// <summary>
  ///   IDocument IVariable Name
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   IDocument IVariable Value
  /// </summary>
  public string? Val { get; set; }
}
