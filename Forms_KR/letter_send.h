#ifndef LETTER_SEND_H
#define LETTER_SEND_H

#include <QWidget>

namespace Ui {
class Letter_send;
}

class Letter_send : public QWidget
{
    Q_OBJECT

public:
    explicit Letter_send(QWidget *parent = nullptr);
    ~Letter_send();

    std::string sender_adderess;

    void showEvent(QShowEvent *event);

signals:
    void open_send_letter(); //for open letter_send

private slots:
    void on_pushButton_clicked();

private:
    Ui::Letter_send *ui;
};

#endif // LETTER_SEND_H
