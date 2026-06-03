namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents?view=word-pia"/>
public partial class Document
{

  /// <summary>
  /// Subscribes a handler to the New event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_new?view=word-pia"/>
#pragma warning disable CS0067 // Event is never used
  public event DocumentEvents2_NewEventHandler OnNew;

  /// <summary>
  /// Subscribes a handler to the Open event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_open?view=word-pia"/>
  public event DocumentEvents2_OpenEventHandler OnOpen;

  /// <summary>
  /// Subscribes a handler to the Close event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_close?view=word-pia"/>
  public event DocumentEvents2_CloseEventHandler OnClose;

  /// <summary>
  /// Subscribes a handler to the Sync event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_sync?view=word-pia"/>
  public event DocumentEvents2_SyncEventHandler OnSync;

  /// <summary>
  /// Subscribes a handler to the XMLAfterInsert event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_xmlafterinsert?view=word-pia"/>
  public event DocumentEvents2_XMLAfterInsertEventHandler OnXMLAfterInsert;

  /// <summary>
  /// Subscribes a handler to the XMLBeforeDelete event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_xmlbeforedelete?view=word-pia"/>
  public event DocumentEvents2_XMLBeforeDeleteEventHandler OnXMLBeforeDelete;

  /// <summary>
  /// Subscribes a handler to the ContentControlAfterAdd event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolafteradd?view=word-pia"/>
  public event DocumentEvents2_ContentControlAfterAddEventHandler OnContentControlAfterAdd;

  /// <summary>
  /// Subscribes a handler to the ContentControlBeforeDelete event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolbeforedelete?view=word-pia"/>
  public event DocumentEvents2_ContentControlBeforeDeleteEventHandler OnContentControlBeforeDelete;

  /// <summary>
  /// Subscribes a handler to the ContentControlOnExit event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolonexit?view=word-pia"/>
  public event DocumentEvents2_ContentControlOnExitEventHandler OnContentControlOnExit;

  /// <summary>
  /// Subscribes a handler to the ContentControlOnEnter event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolonenter?view=word-pia"/>
  public event DocumentEvents2_ContentControlOnEnterEventHandler OnContentControlOnEnter;

  /// <summary>
  /// Subscribes a handler to the ContentControlBeforeStoreUpdate event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolbeforestoreupdate?view=word-pia"/>
  public event DocumentEvents2_ContentControlBeforeStoreUpdateEventHandler OnContentControlBeforeStoreUpdate;

  /// <summary>
  /// Subscribes a handler to the ContentControlBeforeContentUpdate event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolbeforecontentupdate?view=word-pia"/>
  public event DocumentEvents2_ContentControlBeforeContentUpdateEventHandler OnContentControlBeforeContentUpdate;

  /// <summary>
  /// Subscribes a handler to the BuildingBlockInsert event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_buildingblockinsert?view=word-pia"/>
  public event DocumentEvents2_BuildingBlockInsertEventHandler OnBuildingBlockInsert;

}
