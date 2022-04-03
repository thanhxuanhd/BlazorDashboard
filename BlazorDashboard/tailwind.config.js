const colors = require('tailwindcss/colors');
const forms = require("@tailwindcss/forms")({
});

module.exports = {
    purge: {
        enabled: true,
        content: [
            './**/*.html',
            './**/*.razor'
        ],
    },
    darkMode: true,
    theme: [
        colors
    ],
    variants: {
        extend: {},
    },
    plugins: [
        forms
    ],
}