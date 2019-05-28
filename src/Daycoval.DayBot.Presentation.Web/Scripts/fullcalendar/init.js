document.addEventListener('DOMContentLoaded', function () {
    var calendarEl = document.getElementById('calendar');

    var calendar = new FullCalendar.Calendar(calendarEl, {
        plugins: ['interaction', 'dayGrid', 'timeGrid', 'list'],
        locale: 'pt-br',
        selectable: true,
        header: {
            left: 'prev,next today',
            center: 'title',
            right: 'dayGridMonth,timeGridMonth,timeGridWeek,timeGridDay,listWeek'
        },
        navLinks: true,
        nowIndicator: true,
        events: '/Home/Events',
        eventClick: function (info) {
            console.log('Event: ' + info.event.title);
            console.log('Coordinates: ' + info.jsEvent.pageX + ',' + info.jsEvent.pageY);
            console.log('View: ' + info.view.type);
            info.el.style.borderColor = 'red';
        },
        dateClick: function (info) {
            console.log('clicked ' + info.dateStr);
            calendar.addEvent({
                title: 'dynamic event',
                start: info.dateStr,
                allDay: true
            });
        },
        select: function (info) {
            console.log('selected ' + info.startStr + ' to ' + info.endStr);
        },
        eventLimit: true,
        views: {
            dayGrid: {
                eventLimit: 5
            },
        }
    });

    calendar.render();
});