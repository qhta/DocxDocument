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
    get
    {
      return StringValueConverter.GetValue(_Element?.Left);
    }
    set
    {
      _ExistingElement.Left = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   start, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Start
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Start);
    }
    set
    {
      _ExistingElement.Start = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Left Indentation in Character Units
  /// </summary>
  [DataMember]
  public Int32? LeftChars
  {
    get
    {
      return _Element?.LeftChars?.Value;
    }
    set
    {
      _ExistingElement.LeftChars = value;
    }
  }
  
  
  /// <summary>
  ///   startChars, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? StartCharacters
  {
    get
    {
      return _Element?.StartCharacters?.Value;
    }
    set
    {
      _ExistingElement.StartCharacters = value;
    }
  }
  
  
  /// <summary>
  ///   Right Indentation
  /// </summary>
  [DataMember]
  public String? Right
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Right);
    }
    set
    {
      _ExistingElement.Right = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   end, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? End
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.End);
    }
    set
    {
      _ExistingElement.End = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Right Indentation in Character Units
  /// </summary>
  [DataMember]
  public Int32? RightChars
  {
    get
    {
      return _Element?.RightChars?.Value;
    }
    set
    {
      _ExistingElement.RightChars = value;
    }
  }
  
  
  /// <summary>
  ///   endChars, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? EndCharacters
  {
    get
    {
      return _Element?.EndCharacters?.Value;
    }
    set
    {
      _ExistingElement.EndCharacters = value;
    }
  }
  
  
  /// <summary>
  ///   Indentation Removed from First Line
  /// </summary>
  [DataMember]
  public String? Hanging
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Hanging);
    }
    set
    {
      _ExistingElement.Hanging = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Indentation Removed From First Line in Character Units
  /// </summary>
  [DataMember]
  public Int32? HangingChars
  {
    get
    {
      return _Element?.HangingChars?.Value;
    }
    set
    {
      _ExistingElement.HangingChars = value;
    }
  }
  
  
  /// <summary>
  ///   Additional First Line Indentation
  /// </summary>
  [DataMember]
  public String? FirstLine
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.FirstLine);
    }
    set
    {
      _ExistingElement.FirstLine = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Additional First Line Indentation in Character Units
  /// </summary>
  [DataMember]
  public Int32? FirstLineChars
  {
    get
    {
      return _Element?.FirstLineChars?.Value;
    }
    set
    {
      _ExistingElement.FirstLineChars = value;
    }
  }
  
}
