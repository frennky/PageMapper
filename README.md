PageMapper
==========

If you ever used Page Objects when creating automated UI tests, than you know it can be really painful to write Page Object classes by hand. This tool is meant to make it easy to create Page Objects.

What's it for?
--------------

PageMapper is a tool that helps you map web page UI to Page Object classes. Since it uses templates to generate Page Object classes, it's easy to customize it. If you need a Page Object class generated in a specific language or provided templates don't suite you, you can just add new template. The tool uses Razor templating engine which has a nice syntax and makes creating a new templates easy.

How to use it?
--------------

When you run the tool it starts with two windows (it's meant to be used with two monitors). One window (main window) contains selected element details, a list of properties of Page Object and some other details. The other window contains a browser.

The browser window actually hosts stripped (no tabs, default css etc.) Internet Explorer. It uses IE from your system so it'll be the same version. You can see the version in window title.

To select a web element, first, navigate to page you want to map. Then press and hold CTRL key and hover over web element that you want to map. On main window you can see details about that element. Once you select an element, release CTRL key and add element to Page Object property list. Rest should be easy to figure out.