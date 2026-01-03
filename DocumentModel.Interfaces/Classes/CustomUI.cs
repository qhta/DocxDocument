namespace DocumentModel;

/// <summary>
///   Represents the root element for Office UI customization, defining custom ribbons, backstage views, and context menus.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines the top-level container for all Office user
///   interface customizations in an add-in or document. The CustomUI element serves as the root of the UI customization
///   structure, containing definitions for custom commands, ribbon modifications, backstage view customizations, and
///   context menu extensions. This interface enables comprehensive Office UI customization by providing access to
///   major UI components: the <see cref="Ribbon"/> for tab and control customization, the <see cref="Backstage"/>
///   for File menu customization, and <see cref="ContextMenus"/> for right-click menu modifications. The interface
///   also includes callback properties for initialization (<see cref="OnLoad"/>) and image loading (<see cref="LoadImage"/>),
///   which are invoked during the UI customization lifecycle. The <see cref="Commands"/> collection allows definition
///   of custom command handlers that can be referenced by multiple controls throughout the UI. This unified structure
///   ensures consistent customization across all Office UI surfaces and enables add-ins to seamlessly integrate with
///   the native Office user experience. All UI customizations defined through this interface follow Office's ribbon
///   XML schema and support both static definitions and dynamic behavior through callback functions.
/// </remarks>
public interface CustomUI : IModelElement
{
  /// <summary>
  ///   Gets or sets the name of the callback function invoked when the custom UI is loaded.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if no load callback is defined.
  /// </value>
  /// <remarks>
  ///   The OnLoad callback is invoked when the Office application loads the custom UI, providing an opportunity
  ///   to initialize UI state, store references to ribbon objects, and perform setup operations. The callback
  ///   typically receives a ribbon object parameter that enables programmatic control over the custom UI through
  ///   the IRibbonUI interface. This is essential for implementing dynamic UI updates and responding to application
  ///   state changes that occur after the initial UI definition is loaded.
  /// </remarks>
  public string? OnLoad { get; set; }

  /// <summary>
  ///   Gets or sets the name of the callback function that provides images for custom controls.
  /// </summary>
  /// <value>
  ///   A string containing the callback function name, or <c>null</c> if no image loading callback is defined.
  /// </value>
  /// <remarks>
  ///   The LoadImage callback is invoked whenever the Office application needs to retrieve an image for a custom
  ///   control. The callback receives an image identifier as a parameter and should return the corresponding image
  ///   object. This centralized image loading mechanism allows controls to reference images by ID rather than
  ///   embedding image data in each control definition, promoting reuse and efficient resource management. The
  ///   callback is particularly useful for managing large numbers of custom images or loading images dynamically
  ///   based on application state or user preferences.
  /// </remarks>
  public string? LoadImage { get; set; }

  /// <summary>
  ///   Gets or sets the collection of custom command definitions.
  /// </summary>
  /// <value>
  ///   A <see cref="Commands"/> object containing custom command handlers,
  ///   or <c>null</c> if no custom commands are defined.
  /// </value>
  /// <remarks>
  ///   Custom commands define reusable command handlers that can be referenced by multiple controls throughout
  ///   the UI. This promotes code reuse and ensures consistent behavior when the same command is invoked from
  ///   different UI locations (such as ribbon buttons, context menus, or Quick Access Toolbar). Commands define
  ///   the action to perform (onAction callback) and can include enabled/disabled state management, making them
  ///   ideal for implementing complex command logic that applies across multiple UI surfaces.
  /// </remarks>
  public Commands? Commands { get; set; }

  /// <summary>
  ///   Gets or sets the ribbon customization definition.
  /// </summary>
  /// <value>
  ///   A <see cref="Ribbon"/> object defining custom ribbon tabs, groups, and controls,
  ///   or <c>null</c> if no ribbon customization is defined.
  /// </value>
  /// <remarks>
  ///   The ribbon customization defines modifications to the Office ribbon interface, including custom tabs,
  ///   modifications to built-in tabs, custom groups, Quick Access Toolbar customizations, and contextual tab
  ///   sets. The ribbon is the primary UI customization surface in Office applications, providing access to
  ///   commands organized by functionality. Ribbon customizations can add new functionality, reorganize existing
  ///   commands, or provide context-sensitive tools through contextual tabs that appear based on user selection
  ///   or application state.
  /// </remarks>
  public Ribbon? Ribbon { get; set; }

  /// <summary>
  ///   Gets or sets the backstage view customization definition.
  /// </summary>
  /// <value>
  ///   A <see cref="Backstage"/> object defining custom backstage tabs and content,
  ///   or <c>null</c> if no backstage customization is defined.
  /// </value>
  /// <remarks>
  ///   The backstage customization defines modifications to the File menu (backstage view) in Office applications.
  ///   The backstage provides access to document-level operations such as Save, Print, Share, and application
  ///   settings. Custom backstage content can include tabs with custom forms, information displays, and commands
  ///   that don't fit naturally in the ribbon interface. Backstage customizations are ideal for document
  ///   management, settings configuration, and workflows that require more space than typical ribbon controls.
  /// </remarks>
  public Backstage? Backstage { get; set; }

  /// <summary>
  ///   Gets or sets the collection of context menu customizations.
  /// </summary>
  /// <value>
  ///   A <see cref="ContextMenus"/> object containing custom context menu definitions,
  ///   or <c>null</c> if no context menu customizations are defined.
  /// </value>
  /// <remarks>
  ///   Context menu customizations define modifications to right-click menus throughout the Office application.
  ///   Custom context menus can add new commands, modify existing menus, or provide context-sensitive options
  ///   based on the selected object or document element. Context menus provide convenient access to frequently
  ///   used commands specific to the current context, enhancing user productivity by reducing the need to navigate
  ///   through ribbon tabs or dialogs. Multiple context menus can be defined to customize different interaction
  ///   scenarios throughout the application.
  /// </remarks>
  public ContextMenus? ContextMenus { get; set; }
}