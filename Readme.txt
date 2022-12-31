Tabs in dotnet maui have an 'OnAppearing' event which you would expect to be called each time a tab is activated to support initialisation. This is not the case and a 
possible workaround is to initialize data in a static manner and pass arguments using the '<x:Arguments>' construct

links:

Github issue : https://github.com/dotnet/maui/issues/9531
Pass arguments : https://learn.microsoft.com/en-us/dotnet/maui/xaml/pass-arguments?view=net-maui-6.0