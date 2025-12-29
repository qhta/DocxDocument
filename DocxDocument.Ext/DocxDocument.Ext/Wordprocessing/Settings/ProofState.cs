namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies if the grammar and spell checking engines of the last application 
/// to process this document completed checking the grammar and spelling of a the document before the document was last saved. 
/// Applications which modify the document contents without checking spelling or grammar should reset these states as needed.
/// </summary>
[DataContract]
public partial class ProofState : ModelElement<DXW.ProofState>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public ProofState(): base(){ }

  public ProofState(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public ProofState(DXW.ProofState openXmlElement): base(openXmlElement) { } 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Gets or sets the spelling proofing state for the associated content.
  /// </summary>
  /// <remarks>Use this property to indicate whether the content has been checked for spelling errors, and to
  /// specify the result of that check. This property is typically used in document processing scenarios to track or
  /// update the spelling verification status.</remarks>
  [DataMember]
  public DMW.ProofingStateKind? Spelling
  {
    get => _Element?.Spelling?.GetEnumValue<DMW.ProofingStateKind, DXW.ProofingStateValues>();
    set => EVU.SetEnumValue<DMW.ProofingStateKind, DXW.ProofingStateValues>(_ExistingElement, nameof(Spelling), value);
  }

  /// <summary>
  /// Gets or sets the grammar proofing state for the associated element.
  /// </summary>
  /// <remarks>Use this property to determine or specify the grammar checking status, such as whether grammar
  /// errors are present or have been ignored. The value is nullable; a null value indicates that no grammar proofing
  /// state is set.</remarks>
  [DataMember]
  public DMW.ProofingStateKind? Grammar
  {
    get => _Element?.Grammar?.GetEnumValue<DMW.ProofingStateKind, DXW.ProofingStateValues>();
    set => EVU.SetEnumValue<DMW.ProofingStateKind, DXW.ProofingStateValues>(_ExistingElement, nameof(Grammar), value);
  }

}
