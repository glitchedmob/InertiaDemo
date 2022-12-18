# InertiaDemo
A simple demo with ASP.NET, React, and Inertia to tie the two together

## Running for development

### Backend
- `cd InertiaDemo.Backend`
- `dotnet ef database update`
- `dotnet run`

### Frontend
- `cd InertiaDemo.Frontend`
- `npm install`
- `npm start`

At this point there are two servers running, the ASP.NET server and a dev server for the React app.
The React app's dev server is setup to proxy all requests that aren't static files to the ASP.NET server.
This means that you should open the React dev servers address in the browser instead of the ASP.NET address.

## Running for production
### Frontend
- `cd InertiaDemo.Frontend`
- `npm run build`

### Backend
- `cd InertiaDemo.Backend`
- `dotnet run --environment Production`

In this mode only a single server is running, the ASP.NET server, which is the one you'll be opening in the browser to test.
