'use strict';

const switcher = document.querySelector('.btn-darkMode');

const savedTheme = localStorage.getItem('theme')||'light-theme';
document.body.classList.add(savedTheme);

if (switcher) {
    switcher.textContent = savedTheme === 'dark-theme' ? 'Light' : 'Dark'

    switcher.addEventListener('click', function () {
        const isDark = document.body.classList.contains('dark-theme');

        document.body.classList.remove('light-theme', 'dark-theme');

        if (isDark) {
            document.body.classList.add('light-theme');
            localStorage.setItem('theme', 'light-theme');
            this.textContent = 'Dark';
        } else {
            document.body.classList.add('dark-theme');
            localStorage.setItem('theme', 'dark-theme');
            this.textContent = 'Light';
        }
    });

}
