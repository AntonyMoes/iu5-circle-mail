#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <letter_send.h>
#include <QPushButton>

QT_BEGIN_NAMESPACE
namespace Ui { class MainWindow; }
QT_END_NAMESPACE


class message : public QPushButton
{
    Q_OBJECT
public:
    std::string send_address;
    std::string send_letter;


    explicit message(QWidget *parent = 0, std::string send_address = "", std::string send_letter = "");
    ~message();

};


class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

private slots:
    void on_scrollArea_customContextMenuRequested(const QPoint &pos);

    void on_pushButton_2_clicked();

    void on_pushButton_3_clicked();

    void on_pushButton_3_pressed();

    void on_pushButton_4_clicked();

    void push_messege(); //obrabotka push

    void on_lineEdit_textChanged(const QString &arg1);

    void on_pushButton_clicked();

private:
    Ui::MainWindow *ui;
    Letter_send *wLetter_send;
};
#endif // MAINWINDOW_H
