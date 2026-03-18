# Namespace: DocumentModel.Drawings.ChartDrawing

The **DocumentModel.Drawings.ChartDrawing** namespace provides the definitions and structures 
involved in anchoring graphical objects within chart surfaces. 
It allows for the placement, sizing, and interaction of "user shapes" 
(such as text boxes, images, and custom shapes) that are drawn on top of a chart area.

## Core Components

### 1. Anchoring Mechanisms
*   **Relative Anchoring (`RelativeAnchorSize`):** Defines the position and size of a drawing element relative to the chart's structural components (like percentage of width/height).
*   **Absolute Anchoring (`AbsoluteAnchorSize`):** Defines the position and size using fixed coordinates, allowing precise placement independent of relative chart dimensions.
*   **Anchors (`FromAnchor`, `ToAnchor`):** Specify the start and end points for the bounding box of the drawing element.

### 2. Graphical Elements
The namespace supports various types of graphical objects that can be embedded in a chart:
*   **Shapes (`Shape`):** Custom vectors or preset geometries with rich formatting options.
*   **Pictures (`Picture`):** Embedded images (`BlipFill`) anchored to the chart.
*   **Connections (`ConnectionShape`):** Lines or connectors used to link different parts of the chart visuals.
*   **Graphic Frames (`GraphicFrame`):** Containers for non-native graphical objects or complex diagrams.
*   **Groups (`GroupShape`):** Allows grouping multiple drawing elements to be transformed or manipulated as a single unit.

### 3. Visual Properties & Styling
*   **Shape Properties:** Reuses core `Drawings.ShapeProperties` (Visual properties like fill, outline, effects) but scoped for chart contexts.
*   **Styles (`Style`):** methods for referencing line lines, fills, effects, and font styles defined in the document's theme.

### 4. Non-Visual Properties
Extensive support for metadata and behavior settings via "Non-Visual Properties" classs (e.g., `NonVisualShapeProperties`, 
`NonVisualPictureProperties`). These define:
*   **Locks:** Restrictions on editing, moving, or resizing (`ShapeLocks`, `PictureLocks`).
*   **Identification:** Unique IDs (`Id`) and names (`Name`) for programmatic access.
*   **Hyperlinks:** Interaction behaviors like `HyperlinkOnClick` or `HyperlinkOnHover`.

## Functional Role
This namespace bridges the gap between raw data visualization (Charts) and illustrative graphics (Drawings). 
It represents the "User Shapes" layer in a chart part, enabling users to annotate charts with arrows, logos, 
highlights, or explanatory text boxes.
