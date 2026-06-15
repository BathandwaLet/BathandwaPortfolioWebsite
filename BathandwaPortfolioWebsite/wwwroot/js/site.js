'use strict';

const switcher = document.querySelector('.btn-darkMode');
const themeIcon = document.querySelector('#themeIcon');

const savedTheme = localStorage.getItem('theme')||'light-theme';
document.body.classList.add(savedTheme);

if (themeIcon) {
    themeIcon.src = savedTheme === 'dark-theme' ? '/images/darkModeIcons/light-theme.png' : '/images/darkModeIcons/dark-theme.png'
}

if (switcher) {
    
    switcher.addEventListener('click', function () {
        const isDark = document.body.classList.contains('dark-theme');

        document.body.classList.remove('light-theme', 'dark-theme');

        if (isDark) {
            document.body.classList.add('light-theme');
            localStorage.setItem('theme', 'light-theme');
            if (themeIcon) {
                themeIcon.src = '/images/darkModeIcons/dark-theme.png'
            }
        } else {
            document.body.classList.add('dark-theme');
            localStorage.setItem('theme', 'dark-theme');
            if (themeIcon) {
                themeIcon.src = '/images/darkModeIcons/light-theme.png'
            }
        }
    });

}
