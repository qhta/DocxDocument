namespace DocumentModel.Presentation;

/// <summary>
/// Trigger Event
/// </summary>
public enum TriggerEvent
{
  /// <summary>
  /// none.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Trigger Event Enum ( On Begin ).
  /// </summary>
  [XmlEnum("onBegin")]
  OnBegin,
  
  /// <summary>
  /// Trigger Event Enum ( On End ).
  /// </summary>
  [XmlEnum("onEnd")]
  OnEnd,
  
  /// <summary>
  /// Trigger Event Enum ( Begin ).
  /// </summary>
  [XmlEnum("begin")]
  Begin,
  
  /// <summary>
  /// Trigger Event Enum ( End ).
  /// </summary>
  [XmlEnum("end")]
  End,
  
  /// <summary>
  /// Trigger Event Enum ( On Click ).
  /// </summary>
  [XmlEnum("onClick")]
  OnClick,
  
  /// <summary>
  /// Trigger Event Enum ( On Double Click ).
  /// </summary>
  [XmlEnum("onDblClick")]
  OnDoubleClick,
  
  /// <summary>
  /// Trigger Event Enum ( On Mouse Over ).
  /// </summary>
  [XmlEnum("onMouseOver")]
  OnMouseOver,
  
  /// <summary>
  /// Trigger Event Enum ( On Mouse Out ).
  /// </summary>
  [XmlEnum("onMouseOut")]
  OnMouseOut,
  
  /// <summary>
  /// Trigger Event Enum ( On Next ).
  /// </summary>
  [XmlEnum("onNext")]
  OnNext,
  
  /// <summary>
  /// Trigger Event Enum ( On Previous ).
  /// </summary>
  [XmlEnum("onPrev")]
  OnPrevious,
  
  /// <summary>
  /// Trigger Event Enum ( On Stop Audio ).
  /// </summary>
  [XmlEnum("onStopAudio")]
  OnStopAudio,
  
  /// <summary>
  /// onMediaBookmark.
  /// </summary>
  [XmlEnum("onMediaBookmark")]
  OnMediaBookmark,
  
}
