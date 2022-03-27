const colors = require('tailwindcss/colors');
const forms = require("@tailwindcss/forms")({
    strategy: 'class',
});

module.exports = {
    purge: {
        enabled: true,
        content: [
            './**/*.html',
            './**/*.razor'
        ],
    },
    darkMode: false,
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