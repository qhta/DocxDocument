namespace DocumentModel;

/// <summary>
/// Gets or sets the identifier of a built-in control, as defined by the application.
/// </summary>
/// <remarks>The IdMso property is mutually exclusive with the Id and QualifiedId properties. At least one of
/// these identifiers must be specified when defining a control.</remarks>
public interface IBuiltInControl
{
  /// <summary>
  ///   Specifies the identifier of a built-in control.
  ///   The contents of this attribute are application-defined.
  /// 
  ///   The Id, QualifiedId, and IdMso attributes are mutually exclusive. At least one of these attributes MUST be specified.
  /// </summary>
  public string? IdMso { get; set; }

}