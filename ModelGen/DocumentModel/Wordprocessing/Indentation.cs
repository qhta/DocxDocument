namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of indentation properties applied to the current paragraph.
/// </summary>
public partial class Indentation: ModelElement<DXW.Indentation>
{
  public Indentation(): base(){ }
  
  public Indentation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Indentation(DXW.Indentation openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Left Indentation
  /// </summary>
  [DataMember]
  public String? Left
  {
    get => _Element?.Left;
    set => _ExistingElement.Left = value;
  }
  
  
  /// <summary>
  ///   start, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Start
  {
    get => _Element?.Start;
    set => _ExistingElement.Start = value;
  }
  
  
  /// <summary>
  ///   Left Indentation in Character Units
  /// </summary>
  [DataMember]
  public Int32? LeftChars
  {
    get => _Element?.LeftChars?.Value;
    set => _ExistingElement.LeftChars = value;
  }
  
  
  /// <summary>
  ///   startChars, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? StartCharacters
  {
    get => _Element?.StartCharacters?.Value;
    set => _ExistingElement.StartCharacters = value;
  }
  
  
  /// <summary>
  ///   Right Indentation
  /// </summary>
  [DataMember]
  public String? Right
  {
    get => _Element?.Right;
    set => _ExistingElement.Right = value;
  }
  
  
  /// <summary>
  ///   end, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? End
  {
    get => _Element?.End;
    set => _ExistingElement.End = value;
  }
  
  
  /// <summary>
  ///   Right Indentation in Character Units
  /// </summary>
  [DataMember]
  public Int32? RightChars
  {
    get => _Element?.RightChars?.Value;
    set => _ExistingElement.RightChars = value;
  }
  
  
  /// <summary>
  ///   endChars, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? EndCharacters
  {
    get => _Element?.EndCharacters?.Value;
    set => _ExistingElement.EndCharacters = value;
  }
  
  
  /// <summary>
  ///   Indentation Removed from First Line
  /// </summary>
  [DataMember]
  public String? Hanging
  {
    get => _Element?.Hanging;
    set => _ExistingElement.Hanging = value;
  }
  
  
  /// <summary>
  ///   Indentation Removed From First Line in Character Units
  /// </summary>
  [DataMember]
  public Int32? HangingChars
  {
    get => _Element?.HangingChars?.Value;
    set => _ExistingElement.HangingChars = value;
  }
  
  
  /// <summary>
  ///   Additional First Line Indentation
  /// </summary>
  [DataMember]
  public String? FirstLine
  {
    get => _Element?.FirstLine;
    set => _ExistingElement.FirstLine = value;
  }
  
  
  /// <summary>
  ///   Additional First Line Indentation in Character Units
  /// </summary>
  [DataMember]
  public Int32? FirstLineChars
  {
    get => _Element?.FirstLineChars?.Value;
    set => _ExistingElement.FirstLineChars = value;
  }
  
}
