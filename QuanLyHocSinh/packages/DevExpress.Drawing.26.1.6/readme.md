# DevExpress Drawing Library

The DevExpress.Drawing package provides cross-platform drawing primitives and rendering infrastructure for DevExpress .NET components. It includes counterparts to common `System.Drawing` types such as `Font`, `Pen`, `Brush`, `Image`, and related graphics classes. These types allow DevExpress applications to perform drawing operations on Windows, Linux, and macOS.

Use this package with DevExpress products that rely on shared drawing APIs. It provides the core abstractions for text rendering, geometric shapes, image handling, and other graphics operations, but does not include a standalone visual control.

## Key Features

- Cross-platform Drawing Primitives - Provides shared counterparts for common `System.Drawing` types used by DevExpress components.
- Graphics and Text Rendering - Supports drawing operations, text layout, font handling, path and region geometry, and related rendering features.
- Image Support - Enables working with bitmap and vector-based image content in a platform-agnostic way.
- Rendering Engine Integration - Supports both GDI+ on Windows and SkiaSharp on non-Windows platforms.
- Custom Font Support - Allows applications to register and use custom fonts through the drawing library APIs.
- Shared Infrastructure for DevExpress Products - Used by components such as Reporting, Office File API, XAF, XPO, and Dashboard export features.

## How to Use

The **DevExpress.Drawing** package is designed for DevExpress products and middleware that require shared drawing functionality. Install it in your .NET project to access the shared rendering APIs.

On Windows, the package uses the GDI+ rendering engine by default. On Linux and macOS, it automatically uses the SkiaSharp-based rendering engine. You can also reference the dedicated `DevExpress.Drawing.Skia` package when needed.

## Evaluation Period, Pricing Options, and Licensing Terms

Whether you own a license or want to start a 30-day evaluation period, register your DevExpress license key. To obtain your key, log in to the [DevExpress Download Manager](https://www.devexpress.com/ClientCenter/DownloadManager/). Use your existing DevExpress.com account or create a new account for free. For additional registration instructions, see [License Key for DevExpress Products](https://www.devexpress.com/go/Licensing_Documentation.aspx).

If you purchase a license after evaluating a product, re-register your updated DevExpress license key to remove evaluation version warnings/messages. 

This package is included in the following commercial subscriptions:

- [DevExpress Universal Subscription](https://www.devexpress.com/subscriptions/universal.xml)
- [DevExpress WinForms Subscription](https://www.devexpress.com/products/net/controls/winforms/)
- [DevExpress DXperience Subscription](https://www.devexpress.com/subscriptions/dxperience.xml)
- [DevExpress WPF Subscription](https://www.devexpress.com/products/net/controls/wpf/)
- [DevExpress Office File API](https://www.devexpress.com/products/net/office-file-api/)
- [Blazor UI Components](https://www.devexpress.com/blazor/)
- [ASP.NET Core Controls](https://www.devexpress.com/products/net/controls/asp/core.xml)

See [DevExpress Subscriptions & Licensing](https://www.devexpress.com/buy) for subscription comparison tables, purchasing FAQ, and licensing information. 


## Documentation

- [DevExpress.Drawing Graphics Library](https://docs.devexpress.com/CoreLibraries/120509/devexpress-drawing-library)
- [Migrate to DevExpress.Drawing Library](https://docs.devexpress.com/CoreLibraries/403513/devexpress-drawing-library/migrate-to-devexpress-drawing-library)
- [Use DevExpress.Drawing Library to Register Custom Fonts](https://docs.devexpress.com/CoreLibraries/403514/devexpress-drawing-library/use-devexpress-drawing-library-to-register-custom-fonts)

## Software Bill of Materials (SBOM)

To access SBOM files for DevExpress packages, please refer to the following article: [Software Bill of Materials (SBOM) for DevExpress .NET assemblies/NuGet packages, JavaScript, VCL and other redistributable artifacts](https://www.devexpress.com/go/DevExpress_Security_SBOM.aspx).

**See Also**: [Information Security](https://www.devexpress.com/support/information-security.xml) | [Security - What You Need to Know](https://docs.devexpress.com/GeneralInformation/403365)


## Useful Online Resources

- [www.devexpress.com](https://www.devexpress.com/)
- [DevExpress Support Center](https://www.devexpress.com/Support/Center/)
- [DevExpress Blogs](https://community.devexpress.com/blogs/)
