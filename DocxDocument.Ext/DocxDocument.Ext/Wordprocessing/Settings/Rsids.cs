namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the set of revision save ID values for the current document. 
/// Revision save ID values refer to four digit hexadecimal values which uniquely identify an editing session in the life of the current document. 
/// An editing session is the period of time between two subsequent save operations by an application.
/// [Guidance: The set of revision save IDs stored with a document only supplies information about the editing session 
/// in which document components were last saved, which can be used by applications in any manner desired. end guidance]
/// </summary>
public partial class Rsids : ModelElement<DXW.Rsids>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public Rsids(): base(){ }

  public Rsids(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public Rsids(DXW.Rsids openXmlElement): base(openXmlElement) { } 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Specifies the revision save ID which was associated with the first editing session for this document. 
  /// <para>
  /// [Note: This information must be identical between any number of copies of the same document, 
  /// as they all originate from the same original editing session. Applications can use this information as desired. end note]
  /// </para>
  /// </summary>
  [DataMember]
  public HexInt? RsidRoot
  {
    get => _Element?.GetHexIntVal<DXW.RsidRoot>();
    set => _ExistingElement.SetHexIntVal<DXW.RsidRoot>(value);
  }
}
