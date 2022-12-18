const { createProxyMiddleware } = require('http-proxy-middleware');

module.exports = function(app) {
    app.use('/', (req, res, next) => {
        if (req.path.startsWith('/static')) {
            next();
        } else {
            createProxyMiddleware({
                target: 'http://localhost:5103',
                changeOrigin: true,
            })(req, res, next);
        }
    });
};