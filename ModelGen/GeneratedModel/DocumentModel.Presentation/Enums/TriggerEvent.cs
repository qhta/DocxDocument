namespace DocumentModel.Presentation;

public enum TriggerEvent
{

  [XmlEnum("none")]
  None,

  [XmlEnum("onBegin")]
  OnBegin,

  [XmlEnum("onEnd")]
  OnEnd,

  [XmlEnum("begin")]
  Begin,

  [XmlEnum("end")]
  End,

  [XmlEnum("onClick")]
  OnClick,

  [XmlEnum("onDblClick")]
  OnDoubleClick,

  [XmlEnum("onMouseOver")]
  OnMouseOver,

  [XmlEnum("onMouseOut")]
  OnMouseOut,

  [XmlEnum("onNext")]
  OnNext,

  [XmlEnum("onPrev")]
  OnPrevious,

  [XmlEnum("onStopAudio")]
  OnStopAudio,

  [XmlEnum("onMediaBookmark")]
  OnMediaBookmark,
}
