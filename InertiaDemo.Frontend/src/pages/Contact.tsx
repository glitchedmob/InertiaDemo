import { Inertia } from '@inertiajs/inertia';
import { Navigation } from '../components/Navigation';

const Contact = () => {
  const handleSubmit = (event: any) => {
    event.preventDefault();

    Inertia.post('/contact', {
      name: event.target.elements.name.value,
      message: event.target.elements.message.value,
    });
  };

  return (
    <>
      <Navigation />
      <p>Contact</p>
      <form onSubmit={handleSubmit}>
        <label>
          Name
          <br />
          <input type="text" name="name" />
        </label>
        <br />
        <br />
        <label>
          Message
          <br />
          <textarea name="message"></textarea>
        </label>
        <br />
        <br />
        <input type="submit" value="Submit" />
      </form>
    </>
  );
};

export default Contact;
