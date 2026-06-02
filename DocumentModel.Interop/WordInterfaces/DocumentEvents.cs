namespace DocumentModel.Interop.Word;

/// <summary>
/// Events interface for Microsoft Word Document object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event?view=word-pia"/>
public partial interface IDocumentEvents
{

  /// <summary>
  /// Subscribes a handler to the New event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_new?view=word-pia"/>
  public event DocumentEvents2_NewEventHandler New;

  /// <summary>
  /// Subscribes a handler to the Open event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_open?view=word-pia"/>
  public event DocumentEvents2_OpenEventHandler Open;

  /// <summary>
  /// Subscribes a handler to the Close event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_close?view=word-pia"/>
  public event DocumentEvents2_CloseEventHandler Close;

  /// <summary>
  /// Subscribes a handler to the Sync event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_sync?view=word-pia"/>
  public event DocumentEvents2_SyncEventHandler Sync;

  /// <summary>
  /// Subscribes a handler to the XMLAfterInsert event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_xmlafterinsert?view=word-pia"/>
  public event DocumentEvents2_XMLAfterInsertEventHandler XMLAfterInsert;

  /// <summary>
  /// Subscribes a handler to the XMLBeforeDelete event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_xmlbeforedelete?view=word-pia"/>
  public event DocumentEvents2_XMLBeforeDeleteEventHandler XMLBeforeDelete;

  /// <summary>
  /// Subscribes a handler to the ContentControlAfterAdd event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolafteradd?view=word-pia"/>
  public event DocumentEvents2_ContentControlAfterAddEventHandler ContentControlAfterAdd;

  /// <summary>
  /// Subscribes a handler to the ContentControlBeforeDelete event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolbeforedelete?view=word-pia"/>
  public event DocumentEvents2_ContentControlBeforeDeleteEventHandler ContentControlBeforeDelete;

  /// <summary>
  /// Subscribes a handler to the ContentControlOnExit event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolonexit?view=word-pia"/>
  public event DocumentEvents2_ContentControlOnExitEventHandler ContentControlOnExit;

  /// <summary>
  /// Subscribes a handler to the ContentControlOnEnter event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolonenter?view=word-pia"/>
  public event DocumentEvents2_ContentControlOnEnterEventHandler ContentControlOnEnter;

  /// <summary>
  /// Subscribes a handler to the ContentControlBeforeStoreUpdate event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolbeforestoreupdate?view=word-pia"/>
  public event DocumentEvents2_ContentControlBeforeStoreUpdateEventHandler ContentControlBeforeStoreUpdate;

  /// <summary>
  /// Subscribes a handler to the ContentControlBeforeContentUpdate event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolbeforecontentupdate?view=word-pia"/>
  public event DocumentEvents2_ContentControlBeforeContentUpdateEventHandler ContentControlBeforeContentUpdate;

  /// <summary>
  /// Subscribes a handler to the BuildingBlockInsert event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_buildingblockinsert?view=word-pia"/>
  public event DocumentEvents2_BuildingBlockInsertEventHandler BuildingBlockInsert;

}
