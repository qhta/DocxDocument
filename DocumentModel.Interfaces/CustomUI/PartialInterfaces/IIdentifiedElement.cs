namespace DocumentModel;

/// <summary>
/// Interface for elements that have an identifier.
/// </summary>
public interface IIdentifiedElement
{
  /// <summary>
  ///   Specifies the identifier for a custom control. All custom controls MUST have unique identifiers.
  ///   The identifier of a control SHOULD be passed to callback functions to identify which control corresponds to the function call.
  /// </summary>
  public string? Id { get; set; }
}